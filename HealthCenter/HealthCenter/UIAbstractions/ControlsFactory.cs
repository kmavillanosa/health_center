using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace HealthCenter
{
    public interface IControlsFactory
    {
        List<IDialog> Dialogs { get; set; }
        List<IModule> Modules { get; set; }
        List<IPage> Pages { get; set; }
        Form ShellView { get; set; }

        void RegisterModules(List<IModule> modules);
        void RegisterPages(List<IPage> pages);
        void RegisterDialogs(List<IDialog> dialogs);
        void RegisterComponents(List<IComponent> components);

        TControlDetails Resolve<TControlDetails>() where TControlDetails : IUIComponent;
        TControlDetails ResolveWpfControl<TControlDetails>() where TControlDetails :
            System.Windows.Controls.UserControl, IUIComponent;
    }
    public class ControlsFactory : IControlsFactory
    {
        public Form ShellView { get; set; }

        public List<IPage> Pages { get; set; }
        public List<IModule> Modules { get; set; }
        public List<IDialog> Dialogs { get; set; }
        public List<IComponent> Components { get; set; }

        public ControlsFactory(Form form)
        {
            ShellView = form;
            Modules = new List<IModule>();
            Pages = new List<IPage>();
            Dialogs = new List<IDialog>();
        }

        public void RegisterModules(List<IModule> modules)
        {
            Modules = modules;
        }

        public void RegisterPages(List<IPage> pages)
        {
            Pages = pages;
          
        }
        public void RegisterDialogs(List<IDialog> dialogs)
        {
            Dialogs = dialogs;
        }


        public TControlDetails Resolve<TControlDetails>() 
            where TControlDetails : IUIComponent 
        {
            object item = null;
           
            var page = Pages.OfType<TControlDetails>().FirstOrDefault();
            var module = Modules.OfType<TControlDetails>().FirstOrDefault();
            var dialog = Dialogs.OfType<TControlDetails>().FirstOrDefault();


            if (page != null)
                item = page;

            if (module != null)
                item = module;

            if (dialog != null)
                item = dialog;


            return (TControlDetails)item;

        }

    

        public TControlDetails ResolveWpfControl<TControlDetails>() 
            where TControlDetails : System.Windows.Controls.UserControl, IUIComponent
        {
            object item = null;

            var component = Components.OfType<TControlDetails>().FirstOrDefault();

            if (component != null)
                item = component;

            return component;
        }

        public void RegisterComponents(List<IComponent> components)
        {
            Components = components;
        }
    }
}
