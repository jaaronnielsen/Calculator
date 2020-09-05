using CalcLib;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Calculator.WPF
{
    class MainCalcWindowViewModel : BindableBase
    {
        public SimpleCalculator Calculators { get; private set; }
        public ObservableCollection<SimpleCalculator> History { get; set; }


        public MainCalcWindowViewModel(IFileProvider FileProvider)
        {
            fileProvider = FileProvider;
            History = new ObservableCollection<SimpleCalculator>();

            Calculators = new SimpleCalculator();
            Calculators.firstNumber = 1;
            Calculators.secondNumber = 1;
            Calculators.result = 1;
        }

        private DelegateCommand calculateAdd;
        public DelegateCommand CalculateAdd => calculateAdd ??= new DelegateCommand(() =>
            {
            Calculators.AddNumbers();
            History.Add(Calculators);
            Calculators = Calculators.Clone() as SimpleCalculator;
            RaisePropertyChanged(nameof(Calculators));
        });

        private DelegateCommand calculateSubtract;
        public DelegateCommand CalculateSubtract => calculateSubtract ??= new DelegateCommand(() =>
            {
              Calculators.SubtractNumbers();
                History.Add(Calculators);
               Calculators = Calculators.Clone() as SimpleCalculator;
            RaisePropertyChanged(nameof(Calculators));
        });

        private DelegateCommand calculateMultiply;
        public DelegateCommand CalculatMultiply => calculateMultiply ??= new DelegateCommand(() =>
            {
            Calculators.MulitplyNumbers();
            History.Add(Calculators);
            Calculators = Calculators.Clone() as SimpleCalculator;
            RaisePropertyChanged(nameof(Calculators));
        });

        private DelegateCommand calculateDivide;
        public DelegateCommand CalculateDivide => calculateDivide ??= new DelegateCommand(() =>
            {
             Calculators.DivideNumbers();
            History.Add(Calculators);
            Calculators = Calculators.Clone() as SimpleCalculator;
            RaisePropertyChanged(nameof(Calculators));
        });

        private DelegateCommand calculatePower;
        public DelegateCommand CalculatePower => calculatePower ??= new DelegateCommand(() =>
            {
            Calculators.RaiseToPower();
            History.Add(Calculators);
            Calculators = Calculators.Clone() as SimpleCalculator;
            RaisePropertyChanged(nameof(Calculators));
        });

        private bool isBusy;
        public bool IsBusy
        {
            get => isBusy;
            set
            {
                SetProperty(ref isBusy, value);
                ImportFromExcel.RaiseCanExecuteChanged();
            }
        }

        private DelegateCommand importFromExcel;
        public DelegateCommand ImportFromExcel => importFromExcel ??= new DelegateCommand(
            async () =>//execute
            {
                IsBusy = true;
                var rows = await fileProvider.ReadFromExcelAsync(ImportFilePath);
                await Task.Run(() =>
                {
                    Parallel.ForEach(rows, r => r.AddNumbers());
                });
                History.AddRange(rows);
                Calculators = rows.Last().Clone() as SimpleCalculator;
                IsBusy = false;
            },
            () =>//Can Execute
            {
                return fileProvider.FileExists(ImportFilePath) && !IsBusy;
            });

        private DelegateCommand exportToExcel;
        public DelegateCommand ExportToExcel => exportToExcel ??= new DelegateCommand(
            () =>//execute
            {
                fileProvider.ExportFileToExcel(History);
            },
            () =>//canExecute
            {
                return History.Any();
            });

        private string importFilePath;
        private readonly IFileProvider fileProvider;

        public string ImportFilePath
        {
            get => importFilePath;
            set
            {
                importFilePath = value;
                RaisePropertyChanged(nameof(ImportFilePath));
                ImportFromExcel.RaiseCanExecuteChanged();
            }
        }
    }
}
