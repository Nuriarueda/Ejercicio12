using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace Ejercicio12
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 


    // EJERCICIO 1
    /*public partial class MainWindow : Window
    {
        public static readonly DependencyProperty TamañoTextoProperty =
            DependencyProperty.Register(
                "TamañoTexto",                 
                typeof(double),               
                typeof(MainWindow),            
                new PropertyMetadata(12.0)); 

        
        public double TamañoTexto
        {
            get { return (double)GetValue(TamañoTextoProperty); }
            set { SetValue(TamañoTextoProperty, value); }
        }

        public MainWindow()
        {
            InitializeComponent();
            
            this.DataContext = this;  
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            TamañoTexto += 2.0;  
        }
    } */


    // EJERCICIO 2
    /*public class ColorDeFondoTexto : DependencyObject
    {
        public static readonly DependencyProperty FondoProperty =
            DependencyProperty.Register(
                "Fondo",
                typeof(Brush),
                typeof(ColorDeFondoTexto),
                new PropertyMetadata(Brushes.White));

        public Brush Fondo
        {
            get => (Brush)GetValue(FondoProperty);
            set => SetValue(FondoProperty, value);
        }
    }

    public partial class MainWindow : Window
    {
       
        private readonly ColorDeFondoTexto _colorDeFondoTexto;

        public MainWindow()
        {
            InitializeComponent();
            _colorDeFondoTexto = new ColorDeFondoTexto();
            DataContext = _colorDeFondoTexto;
        }

       
        private void ChangeColor_Click(object sender, RoutedEventArgs e)
        {
            _colorDeFondoTexto.Fondo = Brushes.LightBlue;
        }
    }*/


    // EJERCICIO 3
    /*public class ViewModel : DependencyObject
    {
        public static readonly DependencyProperty TextoUsuarioProperty =
            DependencyProperty.Register(
                "TextoUsuario",
                typeof(string),
                typeof(ViewModel),
                new PropertyMetadata(string.Empty));

        public string TextoUsuario
        {
            get => (string)GetValue(TextoUsuarioProperty);
            set => SetValue(TextoUsuarioProperty, value);
        }
    }

    public partial class MainWindow : Window
    {
        private readonly ViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new ViewModel();
            DataContext = _viewModel;
        }
        private void SincronizarTexto_Click(object sender, RoutedEventArgs e)
        {
        }
    }*/


    //EJERCICIO 4
    /* public class ViewModel : DependencyObject
     {
         public static readonly DependencyProperty TextoUsuarioProperty =
             DependencyProperty.Register(
                 "TextoUsuario",
                 typeof(string),
                 typeof(ViewModel),
                 new PropertyMetadata(string.Empty));

         public string TextoUsuario
         {
             get => (string)GetValue(TextoUsuarioProperty);
             set => SetValue(TextoUsuarioProperty, value);
         }
     }
     public partial class MainWindow : Window
     {
         public MainWindow()
         {
             InitializeComponent();
         }
     }*/

    // EJERCICIO 5
    /*
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Nota { get; set; }
        public string Curso { get; set; }
    }

    public class CursoGrupo
    {
        public string Curso { get; set; }
        public ObservableCollection<Estudiante> Estudiantes { get; set; }
    }

    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public ObservableCollection<CursoGrupo> Cursos { get; set; }
        private Estudiante _selectedEstudiante;

        public Estudiante SelectedEstudiante
        {
            get => _selectedEstudiante;
            set
            {
                _selectedEstudiante = value;
                OnPropertyChanged(nameof(SelectedEstudiante));
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            CargarDatos();
        }

        private void CargarDatos()
        {
            Cursos = new ObservableCollection<CursoGrupo>
            {
                new CursoGrupo
                {
                    Curso = "Matemáticas",
                    Estudiantes = new ObservableCollection<Estudiante>
                    {
                        new Estudiante { Nombre = "Ana", Edad = 20, Nota = 9, Curso = "Matemáticas" },
                        new Estudiante { Nombre = "Luis", Edad = 22, Nota = 7.5, Curso = "Matemáticas" }
                    }
                },
                new CursoGrupo
                {
                    Curso = "Física",
                    Estudiantes = new ObservableCollection<Estudiante>
                    {
                        new Estudiante { Nombre = "María", Edad = 21, Nota = 8.5, Curso = "Física" },
                        new Estudiante { Nombre = "Pedro", Edad = 23, Nota = 6, Curso = "Física" }
                    }
                },
                new CursoGrupo
                {
                    Curso = "Química",
                    Estudiantes = new ObservableCollection<Estudiante>
                    {
                        new Estudiante { Nombre = "Sofía", Edad = 20, Nota = 9.5, Curso = "Química" },
                        new Estudiante { Nombre = "Carlos", Edad = 22, Nota = 7, Curso = "Química" }
                    }
                }
            };

            EstudiantesListBox.ItemsSource = Cursos;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }*/



}
