using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MVP.SimpleMVPExample.Entities
{
    public class SimpleMVPExamplePresenter
    {
        private readonly IView view;
        private IModel model;
        public SimpleMVPExamplePresenter(IView formView, Model viewModel)
        {
            this.view = formView;
            this.model = viewModel;           
        }

        public void ReverseTextValue()
        {
            string reversed = ReverseString(view.TextValue);
            model.Reverse(reversed);
        }

        public void SetTextValue()
        {
            model.Set(view.TextValue);
        }

        private static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
