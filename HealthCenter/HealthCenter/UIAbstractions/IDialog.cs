using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCenter
{
    public interface IDialog<TModel> : IDialog
    {
        TModel Data { get; set; }
        void GetModelData(TModel data);
        void SetModelData();
    }
    public interface IDialog : IUIComponent
    {
        Action BeforeSaveAction { get; set; }
    }
}
