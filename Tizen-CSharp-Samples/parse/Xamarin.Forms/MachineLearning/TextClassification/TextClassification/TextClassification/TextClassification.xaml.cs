/*
 * Copyright (c) 2020 Samsung Electronics Co., Ltd. All rights reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using TextClassification.Views;

namespace TextClassification
{
    /// <summary>
    /// Text Classification Application Class
    /// </summary>

    public partial class App : Application
    {
        /// <summary>
        /// Initializes a new instance of the App class.
        /// </summary>
        public App()
        {
            InitializeComponent();

            /* Load main page. */
            MainPage = new NavigationPage(new UserInput());
        }

        /// <summary>
        /// On start method
        /// </summary>
        protected override void OnStart()
        {
            /// Handle when your app starts
        }

        /// <summary>
        /// On sleep method
        /// </summary>
        protected override void OnSleep()
        {
            /* Handle when your app sleeps */
        }

        /// <summary>
        /// On resume method
        /// </summary>
        protected override void OnResume()
        {
            /// Handle when your app resumes
        }
    }
}
