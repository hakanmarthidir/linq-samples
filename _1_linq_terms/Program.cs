using System;

namespace _1_linq_terms
{
    class Program
    {
        static void Main(string[] args)
        {

            //WhereSamples whereSamples = new WhereSamples();

            //WHERE filter
            //whereSamples.WhereSample(35);
            //whereSamples.WhereSampleWithNamedMethod();
            //whereSamples.WhereSampleWithDelegatedMethod();
            //whereSamples.WhereQuerySample();

            //SELECT
            //SelectSamples selectSamples = new SelectSamples();
            //selectSamples.Select1();

            //TAKE-ORDERBY-SKIP
            //TakeOrderBySamples takeOrderBySamples = new TakeOrderBySamples();
            //takeOrderBySamples.TakeSample1();
            //takeOrderBySamples.SkipSample1();
            //takeOrderBySamples.OrderBySample1();
            //takeOrderBySamples.MultiOrderBySample1();

            //ANY ALL FIRST CONTAINS
            //AnyAllContainsFirstSamples anyAllContainsFirstSamples = new AnyAllContainsFirstSamples();
            //anyAllContainsFirstSamples.AllSample();
            //anyAllContainsFirstSamples.AnySample();
            //anyAllContainsFirstSamples.ContainsSample();
            //anyAllContainsFirstSamples.FirstSample();
            //anyAllContainsFirstSamples.FirstOrDefaultSample();
            //anyAllContainsFirstSamples.SingleSample();
            //anyAllContainsFirstSamples.SingleOrDefaultSample();

            //GROUP
            //GroupingSamples groupingJoiningSamples = new GroupingSamples();
            //groupingJoiningSamples.GroupingSample();
            //groupingJoiningSamples.GroupingSample2();
            //groupingJoiningSamples.GroupingSample3();
            //groupingJoiningSamples.GroupingSample4();
            //groupingJoiningSamples.GroupingSample5();

            //JOIN
            JoiningSamples joiningSamples = new JoiningSamples();
            joiningSamples.JoiningSample();
            joiningSamples.LeftJoinSample();
            //joiningSamples.JoiningSample2();
            //joiningSamples.GroupJoiningSample();
            //joiningSamples.GroupJoiningSample2();

            //AGGREGATION OPERATIONS
            //AggregationFunctionsSamples aggregationFunctionsSamples = new AggregationFunctionsSamples();
            //aggregationFunctionsSamples.AggregationSample();
        }
    }
}
