﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Команда на сохранение контакта.
    /// </summary>
    class SaveCommand : ICommand
    {
        /// <summary>
        /// Событие, предоставляющее информацию о возможности вызове команды.
        /// </summary>
        public event EventHandler? CanExecuteChanged;

        /// <summary>
        /// Определяет, может ли выполняться команда.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        /// <returns>Истина.</returns>
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        /// <summary>
        /// Выполняет логику команды.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        public void Execute(object? parameter)
        {
            _execute(parameter);
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="SaveCommand"/>.
        /// </summary>
        /// <param name="execute">Делегат для вызова команды.</param>
        public SaveCommand(Action<object?> execute)
        {
            _execute = execute;
        }

        /// <summary>
        /// Делегат для вызова команды.
        /// </summary>
        private Action<object?> _execute;
    }
}
