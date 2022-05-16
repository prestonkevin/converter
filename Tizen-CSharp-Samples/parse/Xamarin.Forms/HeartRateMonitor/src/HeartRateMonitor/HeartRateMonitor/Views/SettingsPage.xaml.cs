﻿/*
 * Copyright (c) 2017 Samsung Electronics Co., Ltd. All rights reserved.
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

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HeartRateMonitor.Views
{
    /// <summary>
    /// SettingsPage class.
    /// Provides logic for UI SettingsPage.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        #region methods

        /// <summary>
        /// SettingsPage class constructor.
        /// </summary>
        public SettingsPage()
        {
            InitializeComponent();
        }

        #endregion
    }
}