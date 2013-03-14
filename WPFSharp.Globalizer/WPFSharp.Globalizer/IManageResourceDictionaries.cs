﻿#region License
/*
WPF Sharp Globalizer - A project deisgned to make localization and styling
                       easier by decoupling both process from the build.

Copyright (c) 2012, Rhyous.com
All rights reserved.
 
Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:
 
1. Redistributions of source code must retain the above copyright notice, this
   list of conditions and the following disclaimer.
2. Redistributions in binary form must reproduce the above copyright notice,
   this list of conditions and the following disclaimer in the documentation
   and/or other materials provided with the distribution.
3. Use of the source code or binaries for a competing project, whether open
   source or commercial, is prohibited unless permission is specifically
   granted under a separate license by Rhyous.com.
4. Source code enhancements or additions are the property of the author until
   the source code is contributed to this project. By contributing the source
   code to this project, the author immediately grants all rights to
   the contributed source code to Rhyous.com.
 
THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR
ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace WPFSharp.Globalizer
{
    public interface IManageResourceDictionaries
    {
        /// <summary>
        /// An event that is fired when a ResourceDictionary is changed.
        /// </summary>
        event ResourceDictionaryChangedEventHandler ResourceDictionaryChangedEvent;

        /// <summary>
        /// The list of resource dictionary .xaml files
        /// </summary>
        Collection<ResourceDictionary> MergedDictionaries { get; set; }

        /// <summary>
        /// The list of resource dictionary .xaml files
        /// </summary>
        List<String> FileNames { get; set; }

        /// <summary>
        /// Dynamically load a ResourceDictionary from a file
        /// </summary>
        /// <param name="inFile">The file to read for loading the ResourceDictionary.</param>
        EnhancedResourceDictionary LoadFromFile(String inFile);

        /// <summary>
        /// Dynamically load a ResourceDictionary from a list of file names
        /// </summary>
        void LoadDictionariesFromFiles(List<string> inList);

        /// <summary>
        /// Removes a ResourceDictionary.
        /// </summary>
        /// <param name="inResourceDictionaryName">A string representing the ResourceDictionary name.</param>
        void Remove(string inResourceDictionaryName);

        /// <summary>
        /// Removes a ResourceDictionary.
        /// </summary>
        /// <param name="inResourceDictionaryName">A string representing the ResourceDictionary name.</param>
        void RemoveAll();

        /// <summary>
        /// A method to fire the ResourceDictionaryChangedEvent
        /// </summary>
        void NotifyResourceDictionaryChanged(ResourceDictionaryChangedEventArgs inEventArgs);
    }
}
