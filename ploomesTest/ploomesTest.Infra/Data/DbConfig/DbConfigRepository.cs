using ploomesTest.Domain.Models.Enums;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace ploomesTest.Infra.Data.DbConfig
{
    public class DbConfigRepository
    {
        #region Config
        private readonly IConfiguration configuration;

        private const int DefaultTimeout = 300;

        public DbConfigRepository()
        {
            IConfigurationBuilder configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            configuration = configurationBuilder.Build();
        }
        #endregion
        #region Connection Db

        public List<T> ExecuteList<T>(Enviroment.EnviromentDatabase db, string  procedureName, object parameters)
        {
            DataTable dt = ExecuteTable(db, procedureName, parameters);

            return ConvertDataTableList<T>(dt);
        }

        public T ExecuteSelect<T>(Enviroment.EnviromentDatabase db, string procedureName, object parameters)
        {
            DataTable dt = ExecuteTable(db, procedureName, parameters);

            return ConvertDataTable<T>(dt);
        }

        public DataTable ExecuteTable(Enviroment.EnviromentDatabase db, string procedureName, object parameters)
        {
            DataTable dt = new DataTable();

            using (var conn = new SqlConnection(GetConnectionString(db)))
            {
                using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                {
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        cmd.CommandTimeout = DefaultTimeout;
                        cmd.CommandType = CommandType.StoredProcedure;
                        SetParameters(parameters, cmd);

                        conn.Open();
                        da.Fill(dt);
                    }
                }
            }

            return dt;

        }

        public int ExecuteNonQuery(Enviroment.EnviromentDatabase db, string procedureName, object parameters)
        {
            int id = 0;
            using (var conn = new SqlConnection(GetConnectionString(db)))
            {
                using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                {
                    cmd.CommandTimeout = DefaultTimeout;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SetParameters(parameters, cmd);

                    var returnParameter = cmd.Parameters.Add("@ret", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    conn.Open();
                    id = cmd.ExecuteNonQuery();
                }
            }
            return id;
        }

        #endregion

        #region Private Methods

        private List<T> ConvertDataTableList<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        private T ConvertDataTable<T>(DataTable dt)
        {
            T data = Activator.CreateInstance<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data = item;
            }

            return data;
        }

        private T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name.ToUpper() == column.ColumnName.ToUpper() && dr[column.ColumnName] != DBNull.Value)
                    {
                        var targetType = IsNullableType(pro.PropertyType) ? Nullable.GetUnderlyingType(pro.PropertyType) : pro.PropertyType;
                        pro.SetValue(obj, Convert.ChangeType(dr[column.ColumnName], targetType), null);
                    }
                }
            }

            return obj;
        }

        private bool IsNullableType(Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition().Equals(typeof(Nullable<>));
        }

        private static void SetParameters(object parameters, SqlCommand cmd)
        {
            if (parameters != null)
            {
                foreach (var p in parameters.GetType().GetProperties())
                {
                    cmd.Parameters.AddWithValue(p.Name, p.GetValue(parameters, null));
                }
            }
        }

        private string GetConnectionString(Enviroment.EnviromentDatabase db)
        {
            return configuration.GetConnectionString(db.ToString());
        }

        #endregion
    }
}
