using Autofac;
using HealthCenter.UI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCenter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            OverlayHelper helper = new OverlayHelper(this);
        }

        public Autofac.IContainer AppContainer { get; set; }

        public void InitializeDependencies()
        {
            var builder = new ContainerBuilder();

            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
              .Where(type => type.GetInterface(typeof(IPage).Name) != null)
              .AsImplementedInterfaces().SingleInstance();

            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
             .Where(type => type.GetInterface(typeof(IDialog).Name) != null)
             .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
          .Where(type => type.GetInterface(typeof(IComponent).Name) != null)
          .AsImplementedInterfaces().SingleInstance();


            builder.RegisterAssemblyTypes(AppDomain.CurrentDomain.GetAssemblies())
            .Where(type => type.GetInterface(typeof(IModule).Name) != null)
            .AsImplementedInterfaces().SingleInstance();

            builder.RegisterType<AccountContextService>().As<IAccountContextService>().SingleInstance();

            builder.Register(x=> 
            {
                return new ControlsFactory(this);
            }).As<IControlsFactory>().SingleInstance();

            builder.Register(x => 
            {
                return new HealthCenterService(Properties.Settings.Default.Constring);

            }).As<IHealthCenterService>().SingleInstance();

            AppContainer = builder.Build();

           
            var controlsFactory = AppContainer.Resolve<IControlsFactory>();
            var modules = AppContainer.Resolve<IEnumerable<IModule>>();
            var pages = AppContainer.Resolve<IEnumerable<IPage>>();
            var dialogs = AppContainer.Resolve<IEnumerable<IDialog>>();
            var components = AppContainer.Resolve<IEnumerable<IComponent>>();


            controlsFactory.RegisterModules(modules.ToList());
            controlsFactory.RegisterPages(pages.ToList());
            controlsFactory.RegisterDialogs(dialogs.ToList());
            controlsFactory.RegisterComponents(components.ToList());


            var login = controlsFactory.Resolve<LoginView>();
            login.Dock = DockStyle.Fill;
            Controls.Clear();
            Controls.Add(login);


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeDependencies();
        }
    }

   
}
