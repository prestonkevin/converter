
//Copyright 2018 Samsung Electronics Co., Ltd
//
//Licensed under the Apache License, Version 2.0 (the "License");
//you may not use this file except in compliance with the License.
//You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.

using ServiceDiscovery.Model;
using Tizen.Wearable.CircularUI.Forms;
using Xamarin.Forms.Xaml;

namespace ServiceDiscovery.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailsPage : CirclePage
    {
        /// <summary>
        /// Property providing DNSSDService data.
        /// </summary>
        public DnssdService Service { get; set; }

        /// <summary>
        /// DetailsPage constructor.
        /// </summary>
        /// <param name="service"> Service data that will be diplayed. </param>
        public DetailsPage(DnssdService service)
        {
            Service = service;
            InitializeComponent();
            BindingContext = this;
        }
    }
}