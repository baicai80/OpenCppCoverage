﻿// OpenCppCoverage is an open source code coverage for C++.
// Copyright (C) 2014 OpenCppCoverage
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using EnvDTE;
using Microsoft.VisualStudio.VCProjectEngine;
using System.Collections.Generic;

namespace OpenCppCoverage.VSPackage
{
    class ExtendedProject
    {        
        //---------------------------------------------------------------------
        public ExtendedProject(Project project, VCProject vcProject)
        {
            this.project_ = project;
            this.vcProject_ = vcProject;
        }
        
        //---------------------------------------------------------------------
        public string UniqueName
        {
            get
            {
                return project_.UniqueName;
            }
        }

        //---------------------------------------------------------------------
        public string ProjectDirectory
        {
            get
            {
                return vcProject_.ProjectDirectory;
            }
        }
        
        //---------------------------------------------------------------------
        public List<VCConfiguration> Configurations
        {
            get
            {
                var configurations = new List<VCConfiguration>();
                foreach (VCConfiguration configuration in vcProject_.Configurations)
                    configurations.Add(configuration);

                return configurations;
            }
        }

        //---------------------------------------------------------------------
        public List<VCFile> Files
        {
            get
            {
                var files = new List<VCFile>();
                foreach (VCFile file in vcProject_.Files)
                    files.Add(file);
                return files;
            }
        }

        readonly Project project_;
        readonly VCProject vcProject_;
    }
}
