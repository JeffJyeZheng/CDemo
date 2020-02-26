using AutoMapper;
using Demo.Mappings;
using Demo.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.RegistrationByConvention;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            ILogger logger = LogManager.GetCurrentClassLogger();

            IUnityContainer unitycontainer = new UnityContainer(); // 建立物件
            unitycontainer.RegisterTypes(
                AllClasses.FromLoadedAssemblies(),
                WithMappings.FromMatchingInterface,
                WithName.Default,
                WithLifetime.Hierarchical);

            unitycontainer.RegisterInstance<ILogger>(logger); // 注入

            IClass1 class1 = unitycontainer.Resolve<IClass1>();
            //IClass class2 = new Class1(logger);

            class1.Log();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<BModelProfile>();
            });

            var mapper = config.CreateMapper();
            var amodel = new AModel
            {
                Name = "Jeff",
                No = 123
            };
            BModel bmodel = mapper.Map<BModel>(amodel);
        }
    }
}
