using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ploomesTest.Domain.Interfaces.Command.Genre
{
    public interface IDeleteGenreDomain
    {
        public bool DeleteGenre(int genreId);
    }
}
