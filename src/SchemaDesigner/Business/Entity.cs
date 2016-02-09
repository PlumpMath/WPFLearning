namespace SchemaDesigner.Business
{
    public class Entity : BusinessBase
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                SetProperty(ref name, value);
            }
        }
    }
}
