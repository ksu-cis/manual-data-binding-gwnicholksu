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
using ManualDataBinding.Data;

namespace ManualDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Create the note to add to our editor
        Note note = new Note();

        public MainWindow()
        {
            InitializeComponent();
            Editor.Note = note;
        }

        /// <summary>
        /// Evenbt handler tocreate a new note and apply it to the editor
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">the event args</param>
        public void OnNewNote(object sender, RoutedEventArgs e)
        {
            note = new Note();
            Editor.Note = note;
        }

        /// <summary>
        /// Evenbt handler to clear the contents of the note
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">the event args</param>
        public void OnClearNote(object sender, RoutedEventArgs e)
        {
            note.Body = "";
        }

        /// <summary>
        /// Event Handler to mutate the current note
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The event args</param>
        public void OnMutateNote(object sender, RoutedEventArgs e)
        {
            note.Title = "Darth Plagueis The Wise";
            note.Body = "Did you ever hear the tragedy of Darth Plagueis The Wise? " +
                        "I thought not. It's not a story the Jedi would tell you. It's a Sith legend. " +
                        "Darth Plagueis was a Dark Lord of the Sith, so powerful and so wise he could use " +
                        "the Force to influence the midichlorians to create life… He had such a knowledge " +
                        "of the dark side that he could even keep the ones he cared about from dying. " +
                        "The dark side of the Force is a pathway to many abilities some consider to be unnatural. " +
                        "He became so powerful… the only thing he was afraid of was losing his power, which eventually, " +
                        "of course, he did. Unfortunately, he taught his apprentice everything he knew, " +
                        "then his apprentice killed him in his sleep. Ironic. He could save others from death, but not himself.";
        }
    }
}
