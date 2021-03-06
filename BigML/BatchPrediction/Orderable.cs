﻿using BigML.Meta;

namespace BigML
{
    using Meta.Key;

    public partial class BatchPrediction
    {
        /// <summary>
        /// Orderable properties for Batch Predictions
        /// </summary>
        public class Orderable : Orderable<BatchPrediction>
        {
            /// <summary>
            /// The dataset/id that was used to build the batch prediction.
            /// </summary>
            public String DataSet
            {
                get { return Object.dataset; }
            }

            /// <summary>
            /// Whether the dataset is still available or has been deleted.
            /// </summary>
            public Bool DataSetStatus
            {
                get { return Object.dataset_status; }
            }
        }
    }
}