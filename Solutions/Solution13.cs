using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    internal class Solution13
    {
        List<String> threads = new List<String>();
        List<String> time_slices = new List<String>();
        public void setInput()
        {
            threads = ["ABCDE"];
            time_slices = ["0 20", "0 21"];
        }

        public String runThreadsaccurence()
        {
            String ThreadsAccurence = "";

            //indexes[] for representing each threads index
            int[] indexes = new int[threads.Count];

            //initialy allthreads are start running form 0 index

            for (int i = 0; i < indexes.Length; i++)
                indexes[i] = 0;
            foreach (String time_slice in time_slices)
            {
                int time_slice_index = 0;
                String index = "";

                while (time_slice_index < time_slice.Length && time_slice[time_slice_index] != ' ')
                {
                    index += time_slice[time_slice_index++];
                }
                int Thread_no = int.Parse(index);

                String dur = "";
                while (time_slice_index < time_slice.Length)
                {
                    dur += time_slice[time_slice_index++];
                }
                int duration = int.Parse(dur);


                for (int time = 0; time < duration; time++)
                {
                    String thread = threads[Thread_no];
                    ThreadsAccurence += thread[indexes[Thread_no]];


                    indexes[Thread_no]++;
                    indexes[Thread_no] %= thread.Length;

                }
            }

            return ThreadsAccurence;
        }
    }
}
