﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat.Kino.Helper
{
    interface iNavigationService
    {
        void Navigate(Type sourcePage, object parameter);
    }
}