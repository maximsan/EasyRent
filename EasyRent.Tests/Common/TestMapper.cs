using AutoMapper;
using EasyRent.BusinessLayer.Interfaces;
using System.Reflection;

namespace EasyRent.Tests.Common
{
    public static class TestMapper
    {
        private static Mapper _instance;
        private static object locker = new object();

        public static Mapper Instance
        {
            get
            {
                if (_instance is null)
                {
                    lock (locker)
                    {
                        if (_instance is null)
                        {
                            var config = new MapperConfiguration(cfg =>
                            {
                                cfg.AddMaps(Assembly.GetAssembly(typeof(IUserService)));
                            });

                            _instance = new Mapper(config);
                        }
                    }
                }

                return _instance;
            }
        }
    }
}