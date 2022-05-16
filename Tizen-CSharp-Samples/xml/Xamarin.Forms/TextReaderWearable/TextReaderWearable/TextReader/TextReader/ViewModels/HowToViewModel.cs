/*
 * Copyright 2019 Samsung Electronics Co., Ltd. All rights reserved.
 *
 * Licensed under the Flora License, Version 1.1 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://floralicense.org/license
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Windows.Input;
using TextReader.Views;
using Xamarin.Forms;

namespace TextReader.ViewModels
{
    /// <summary>
    /// Provides commands and methods responsible for 'how-to' page view model state.
    /// </summary>
    public class HowToViewModel
    {
        #region properties

        /// <summary>
        /// Navigates to text reader page.
        /// </summary>
        public ICommand NavigateToTextReaderCommand { get; }

        #endregion

        #region methods

        /// <summary>
        /// Initializes the view model for 'how-to' page.
        /// </summary>
        public HowToViewModel()
        {
            NavigateToTextReaderCommand = new Command(ExecuteNavigateToTextReaderCommand);
        }

        /// <summary>
        /// Handles execution of NavigateToTextReaderCommand.
        /// Navigates to text reader page.
        /// </summary>
        private void ExecuteNavigateToTextReaderCommand()
        {
            DependencyService.Get<IPageNavigation>().NavigateToTextReader();
        }

        #endregion
    }
}
