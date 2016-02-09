using Prism.Mvvm;
using SchemaDesigner.Business;
using System.Collections.Generic;

namespace SchemaDesigner
{
    public class ShellViewModel : BindableBase
    {

        private List<Entity> entities = new List<Entity>();
        public List<Entity> Entities
        {
            get { return this.entities; }
            set { this.SetProperty<List<Entity>>(ref this.entities, value); }

        }
    }
}
