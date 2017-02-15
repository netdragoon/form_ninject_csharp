using Ninject.Modules;
namespace WindowsFormsApplication3
{
    public class FormModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMount>().To<Mount>();
        }

        public static FormModule Create()
        {
            return new FormModule();
        }
    }
}
