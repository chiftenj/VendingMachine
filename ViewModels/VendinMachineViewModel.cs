using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Threading;
using Vending_Machine.Commands;
using Vending_Machine.DataTypes.Interfaces;
using Vending_Machine.Models.VendingMachine;

namespace Vending_Machine.ViewModels
{
    class VendinMachineViewModel : BaseViewModel
    {
        private const String LOAD_ORDER = "LOAD";
        private const String ORDER_CANCELED = "CANCELED";
        private const String ORDER_COMPLETE = "COMPLETE";

        private String _buttonState = LOAD_ORDER;

        public String ButtonState 
        {
            get { return _buttonState; }
            set { _buttonState = value;
                OnPropertyChanged(nameof(ButtonState));
            }
        }


        private CancellationTokenSource _cancelationToken;


        private ObservableCollection<RecipeState> _recipeDetials;

        public ObservableCollection<RecipeState> RecipeDetials
        {
            get { return _recipeDetials; }
            set
            {
                _recipeDetials = value;
                OnPropertyChanged(nameof(RecipeDetials));
            }
        }


        private String _imageAddress;

        public String ImageAddress
        {
            get { return _imageAddress; }
            set
            {
                _imageAddress = value;

                OnPropertyChanged(nameof(ImageAddress));
            }
        }

        private String _name;

        public String Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));

            }
        }


        public String BackIconAddress { get; set; } = "/Images/curve-arrow-point-left.png";
       

        private bool _canBackToManu = false;

        public bool CanBackToMenu
        {
            get { return _canBackToManu ; }
            set
            {
                _canBackToManu = value;
                OnPropertyChanged(nameof(CanBackToMenu));
            }
        }
        public RelayCommand<object> LoadedCommand { get; set; }

        public RelayCommand<object> CancelOrder { get; set; }


        private Beverage _beverage;

        private String WaiteImgAddress = "/Images/wait.png";
        private String LoadImgAddress = "/Images/load.png";
        private String CompleteImgAddress = "/Images/complete.png";


        public VendinMachineViewModel(Beverage beverage)
        {

            RecipeDetials = new ObservableCollection<RecipeState>();
            beverage.RecipeDetail.ForEach(x =>
            {
                RecipeDetials.Add(new RecipeState() { Name = x, StateImageAddress = WaiteImgAddress });
            });
            ImageAddress = beverage.ImageAddress;
            Name = beverage.Name;
            _beverage = beverage;

            Init();
        }



        public void Init()
        {
            LoadedCommand = new RelayCommand<object>(async x =>
          {
              await Start();
          });

            CancelOrder = new RelayCommand<object>( x =>
            {
                if (!_cancelationToken.Token.IsCancellationRequested && ButtonState != ORDER_COMPLETE)
                {
                    _cancelationToken.Cancel();
                    ButtonState = ORDER_CANCELED;
                    CanBackToMenu = true;
                }
            });
        }

        public async Task Start()
        {
            int i = 0;
            var vmo = new VendingMachineOperator(_beverage);
            _cancelationToken = new CancellationTokenSource();
            foreach (var time in vmo.Start())
            {
                //now you can do your stuff to the Observable Collection
                RecipeDetials[i] = new RecipeState()
                {
                    StateImageAddress = LoadImgAddress,
                    Name = RecipeDetials[i].Name
                };
                try
                {

               
                await Task.Delay(TimeSpan.FromSeconds(time), _cancelationToken.Token);
                }
                catch (Exception)
                {
                    return;
                }
                RecipeDetials[i] = new RecipeState()
                {
                    StateImageAddress = CompleteImgAddress,
                    Name = RecipeDetials[i].Name,
                };
                i++;
            }
            ButtonState = ORDER_COMPLETE;
            CanBackToMenu = true;


        }
    }

    class RecipeState : BaseViewModel
    {

        public String Name { get; set; }

        public String StateImageAddress { get; set; }

    }
}
