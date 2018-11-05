using AmazingAgenda.Application.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace AmazingAgenda.Application.ViewModels.Mobile
{
    public class ContactMobileViewModel : ContactViewModel, INotifyPropertyChanged
    {
        private string _name;
        public override string Name
        {
            get => _name;
            set => SetPropertyAndNotify(ref _name, value);
        }
        private DateTime _birth;
        public override DateTime Birth
        {
            get => _birth;
            set => SetPropertyAndNotify(ref _birth, value);
        }
        private string _email;
        public override string Email
        {
            get => _email;
            set => SetPropertyAndNotify(ref _email, value);
        }
        private string _phone;
        public override string Phone
        {
            get => _phone;
            set => SetPropertyAndNotify(ref _phone, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Dispara notificação apenas se o valor de uma propriedade foi alterada.
        /// </summary>
        /// <typeparam name="T">Tipo da propriedade</typeparam>
        /// <param name="variable">Referencia </param>
        /// <param name="value">Valor a ser atribuido.</param>
        /// <param name="propertyNames">Nome da propriedade para notificar os listeners.  
        /// Nome da propriedade para notificar os listeners.  
        /// Esse valor é opcional porque será preenchido pelo compilador através do CallerMemberName.</param>
        /// <returns>Retorna TRUE se o valor foi alterado.</returns>
        protected bool SetPropertyAndNotify<T>(ref T variable, T value, [CallerMemberName]string propertyName = null)
        {
            if (object.Equals(variable, value))
                return false;

            variable = value;
            this.OnPropertyChanged(propertyName);
            return true;
        }

        /// <summary>
        /// Notifica aos listeners que uma determinada propriedade mudou..
        /// </summary>
        /// <param name="propertyNames">Nome da propriedade para notificar os listeners.</param>
        protected void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
