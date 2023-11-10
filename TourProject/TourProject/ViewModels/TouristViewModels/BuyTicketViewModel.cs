using Databases.Contexts;
using GalaSoft.MvvmLight.Command;
using Models.DTO;
using Models.Entities.DerivedEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TourProject.Views.TouristViews;

namespace TourProject.ViewModels.TouristViewModels
{
    internal class BuyTicketViewModel : ITourDBContext
    {
        #region Fields
        private BuyTicketView _thisView;
        #region Private
        private TextBox _textbox_CardNumber;
        private TextBox _textbox_CVC;
        #endregion
        public TourDbContext DbContext { get ; set ; }
        public Tourist SelectedTourist { get; set; }
        public BankCard SelectedBankCard { get; set; }
        public Ticket SelectedTicket { get; set; }
        #endregion

        #region Commands
        public RelayCommand OK_Command { get; set; }
        public RelayCommand Cancel_Command { get; set; }
        #endregion

        #region Command functions
        private void OK()
        {
            try
            {
                if (SelectedBankCard.Balance >= SelectedTicket.Price)
                {
                    SelectedBankCard.Balance -= SelectedTicket.Price;
                    SelectedTicket.TouristId= SelectedTourist.Id;
                    DbContext.SaveChanges();
                }
                else throw new Exception("Balansda kifayet qeder mebleg yoxdur!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cancel()
        {
            _thisView.Close();
        }
        #endregion

        #region Other functions
        private BankCard GetBankCard(Tourist selectedTourist)
        {
            BankCard? bankCard = (from bankcard in DbContext.BankCards
                           join tourist in DbContext.Tourists on bankcard.TouristId equals tourist.Id
                           where selectedTourist.Id == tourist.Id
                           select bankcard).FirstOrDefault();

            return bankCard!;
        }
        #endregion

        #region Constructor
        public BuyTicketViewModel
            (
            BuyTicketView thisView,
            ref TextBox textbox_CardNumber,
            ref TextBox textbox_CVC,
            ref TourDbContext dbContext,
            ref Tourist selectedTourist,
            ref Ticket ticket
            )
        {
            _thisView = thisView;
            DbContext = dbContext;
            SelectedTourist = selectedTourist;
            _textbox_CardNumber = textbox_CardNumber;
            _textbox_CVC = textbox_CVC;
            OK_Command = new RelayCommand(OK);
            Cancel_Command = new RelayCommand(Cancel);
            SelectedBankCard = GetBankCard(selectedTourist);
            SelectedTicket= ticket;
        }
        #endregion
    }
}
