using HealthCenter.UI.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCenter
{
    public class DialogActivator
    {
        public static void OpenDialog<TControl>(TControl page, string title, Action saveCallBack, 
            bool AllowButtons = true,
            Action<TControl> beforeSendCallback = null)
            where TControl : UserControl, IDialog
        {
            if(page != null)
            {
                var window = new ChildForm();
                
                if(AllowButtons == false)
                {
                    window.splitContainer1.Panel2Collapsed = true;
                }

                window.SaveAction = () =>
                {
                    page.BeforeSaveAction?.Invoke();
                    beforeSendCallback?.Invoke(page);
                    saveCallBack();
                };

                window.ShowInTaskbar = false;

                //window.TopMost = true;
                window.BackColor = Color.Gainsboro;
                window.Text = title;
                window.ControlHandler.ClientSize = page.Size;
                window.MinimumSize = new Size(page.Width, page.Height);
                page.Dock = DockStyle.Fill;
                window.ControlHandler.Controls.Add(page);

                if (OverlayHelper.OpenOverLay(window) == DialogResult.OK)
                {
                    window.SaveAction();
                }

            }

        }
    }
}
