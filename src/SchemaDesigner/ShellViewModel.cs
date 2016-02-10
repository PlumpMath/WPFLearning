using Prism.Commands;
using Prism.Mvvm;
using SchemaDesigner.Business;
using System.Collections.Generic;
using System;
using System.Windows;
using Prism.Events;

namespace SchemaDesigner
{
    public class ShellViewModel : BindableBase
    {
        IEventAggregator eventAggregator;

        public DelegateCommand AddClassCommand { get; set; }
        public DelegateCommand AddInterfaceCommand { get; set; }
        public DelegateCommand AddPropertyCommand { get; set; }
        public DelegateCommand DeleteClassCommand { get; set; }
        public DelegateCommand DeleteInterfaceCommand { get; set; }
        public DelegateCommand DeletePropertyCommand { get; set; }
        public DelegateCommand ImportClassCommand { get; set; }
        public DelegateCommand ExportClassCommand { get; set; }
        public DelegateCommand HelpAboutCommand { get; set; }
        public DelegateCommand CloseSchemaCommand { get; set; }
        public DelegateCommand SelectNoneCommand { get; set; }


        public ShellViewModel(IEventAggregator eventAggregator) {

            this.eventAggregator = eventAggregator;
            this.eventAggregator.GetEvent<Events.ApplicationCloseEvent>().Subscribe(this.CloseCommandExecuted);
            //this.eventAggregator.GetEvent<Events.ApplicationOpenEvent>().Subscribe(this.OpenCommandExecuted);

            AddClassCommand = new DelegateCommand(AddClassCommandExecuted, AddClassCommandCanExecute);
            AddInterfaceCommand = new DelegateCommand(AddInterfaceCommandExecuted, AddInterfaceCommandCanExecute);
            AddPropertyCommand = new DelegateCommand(AddPropertyCommandExecuted, AddPropertyCommandCanExecute);
            DeleteClassCommand = new DelegateCommand(DeleteClassCommandExecuted, DeleteClassCommandCanExecute);
            DeleteInterfaceCommand = new DelegateCommand(DeleteInterfaceCommandExecuted, DeleteInterfaceCommandCanExecute);
            DeletePropertyCommand = new DelegateCommand(DeletePropertyCommandExecuted, DeletePropertyCommandCanExecute);
            ImportClassCommand = new DelegateCommand(ImportClassCommandExecuted, ImportClassCommandCanExecute);
            ExportClassCommand = new DelegateCommand(ExportClassCommandExecuted, ExportClassCommandCanExecute);
            HelpAboutCommand = new DelegateCommand(HelpAboutCommandExecuted, HelpAboutCommandCanExecute);
            CloseSchemaCommand = new DelegateCommand(CloseSchemaCommandExecuted, CloseSchemaCommandCanExecute);
            SelectNoneCommand = new DelegateCommand(SelectNoneCommandExecuted, SelectNoneCommandCanExecute);
        }

        private bool SelectNoneCommandCanExecute()
        {
            return false;
        }

        private void SelectNoneCommandExecuted()
        {
            throw new NotImplementedException();
        }

        private bool HelpAboutCommandCanExecute()
        {
            return true;
        }

        private void HelpAboutCommandExecuted()
        {
            MessageBox.Show("Display the help about view!");
        }

        private bool ExportClassCommandCanExecute()
        {
            return false;
        }

        private void ExportClassCommandExecuted()
        {
            throw new NotImplementedException();
        }

        private bool ImportClassCommandCanExecute()
        {
            return false;
        }

        private void ImportClassCommandExecuted()
        {
            throw new NotImplementedException();
        }

        private bool AddPropertyCommandCanExecute()
        {
            return false;
        }

        private void AddPropertyCommandExecuted()
        {
            throw new NotImplementedException();
        }

        private bool AddInterfaceCommandCanExecute()
        {
            return false;
        }

        private void AddInterfaceCommandExecuted()
        {
            throw new NotImplementedException();
        }

        private bool AddClassCommandCanExecute()
        {
            return false;
        }

        private void AddClassCommandExecuted()
        {
            throw new NotImplementedException();
        }

        private bool DeletePropertyCommandCanExecute()
        {
            return false;
        }

        private void DeletePropertyCommandExecuted()
        {
            throw new NotImplementedException();
        }

        private bool DeleteInterfaceCommandCanExecute()
        {
            return false;
        }

        private void DeleteInterfaceCommandExecuted()
        {
            throw new NotImplementedException();
        }

        private bool DeleteClassCommandCanExecute()
        {
            return false;
        }

        private void DeleteClassCommandExecuted()
        {
            throw new NotImplementedException();
        }

        private bool PasteCommandCanExecute()
        {
            return false;
        }

        private void PasteCommandExecuted()
        {
            throw new NotImplementedException();
        }

        private bool CopyCommandCanExecute()
        {
            return false;
        }

        private void CopyCommandExecuted()
        {
            throw new NotImplementedException();
        }

        private bool CutCommandCanExecute()
        {
            return false;
        }

        private void CutCommandExecuted()
        {
            throw new NotImplementedException();
        }

        private bool RedoCommandCanExecute()
        {
            return false;
        }

        private void RedoCommandExecuted()
        {
            throw new NotImplementedException();
        }

        private bool UndoCommandCanExecute()
        {
            return false;
        }

        private void UndoCommandExecuted()
        {
            throw new NotImplementedException();
        }

        private bool SaveAsSchemaCommandCanExecute()
        {
            return false;
        }

        private void SaveAsSchemaCommandExecuted()
        {
            throw new NotImplementedException();
        }

        private bool SaveSchemaCommandCanExecute()
        {
            return false;
        }

        private void SaveSchemaCommandExecuted()
        {
            throw new NotImplementedException();
        }

        private bool CloseSchemaCommandCanExecute()
        {
            return false;
        }

        private void CloseSchemaCommandExecuted()
        {
            throw new NotImplementedException();
        }

        private bool OpenSchemaCommandCanExecute()
        {
            return false;
        }

        private void OpenSchemaCommandExecuted()
        {
            throw new NotImplementedException();
        }

        private bool CloseCommandCanExecute()
        {
            return true;
        }

        private void CloseCommandExecuted(bool close)
        {
            Application.Current.Shutdown();
        }

        private void NewSchemaCommandExecuted()
        {

        }

        private bool NewSchemaCommandCanExecute()
        {
            return false;
        }

        private List<Schema> entities = new List<Schema>();
        public List<Schema> Entities
        {
            get { return this.entities; }
            set { this.SetProperty<List<Schema>>(ref this.entities, value); }

        }
    }
}
