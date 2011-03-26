using StructureMap;
using MvcMovie.Models.Repository;
using MvcMovie.Models;
namespace MvcMovie {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            x.For<IMovieContext>().HttpContextScoped().Use<MovieContext>();
                            x.For<IMovieRepository>().HttpContextScoped().Use<MovieRepository>();
                        });
            return ObjectFactory.Container;
        }
    }
}