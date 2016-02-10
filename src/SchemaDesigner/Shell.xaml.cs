using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SchemaDesigner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Shell : Window
    {
        IEventAggregator eventAggregator;

        public Shell(ShellViewModel viewModel, IEventAggregator eventAggregator)
        {
            InitializeComponent();
            this.DataContext = viewModel;
            this.eventAggregator = eventAggregator;
        }

        private void NewCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void NewCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            this.eventAggregator.GetEvent<Events.ApplicationNewEvent>().Publish(String.Empty);
        }

        private void OpenCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void OpenCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            this.eventAggregator.GetEvent<Events.ApplicationOpenEvent>().Publish(String.Empty);
        }

        private void SaveCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

        }

        private void SaveCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            this.eventAggregator.GetEvent<Events.ApplicationSaveEvent>().Publish(String.Empty);
        }

        private void SaveAsCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

        }

        private void SaveAsCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void CloseCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CloseCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            this.eventAggregator.GetEvent<Events.ApplicationCloseEvent>().Publish(true);
        }

        private void UndoCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

        }

        private void UndoCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            this.eventAggregator.GetEvent<Events.ApplicationUndoEvent>().Publish(String.Empty);
        }

        private void RedoCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

        }

        private void RedoCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            this.eventAggregator.GetEvent<Events.ApplicationRedoEvent>().Publish(String.Empty);
        }

        private void CutCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

        }

        private void CutCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            this.eventAggregator.GetEvent<Events.ApplicationCutEvent>().Publish(String.Empty);
        }

        private void CopyCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

        }

        private void CopyCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            this.eventAggregator.GetEvent<Events.ApplicationCopyEvent>().Publish(String.Empty);
        }

        private void PasteCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

        }

        private void PasteCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            this.eventAggregator.GetEvent<Events.ApplicationPasteEvent>().Publish(String.Empty);
        }

        private void DeleteCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

        }

        private void DeleteCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void SelectAllCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

        }

        private void SelectAllCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void HelpCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void HelpCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Display help!!!");
        }
    }
}
