﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigML
{
    public partial class Evaluation : Response
    {


        /// <summary>
        /// The name of the evaluation as your provided or based on the name
        /// of the dataset and de model/ensemble by default.
        /// </summary>
        public string Name
        {
            get { return Object.name; }
        }


        /// <summary>
        /// The dataset/id that was used to build the dataset.
        /// </summary>
        public string DataSet
        {
            get { return Object.dataset; }
        }



        /// <summary>
        /// Whether the dataset is still available or has been deleted.
        /// </summary>
        public bool DataSetStatus
        {
            get { return Object.dataset_status; }
        }


        /// <summary>
        /// A description of the status of the evaluation. It includes a code, a message,
        /// and some extra information.
        /// </summary>
        public Status StatusMessage
        {
            get { return new Status(Object.status); }
        }
    }
}
