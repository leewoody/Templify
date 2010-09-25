#region License

//-------------------------------------------------------------------------------------------------
// <auto-generated> 
// Marked as auto-generated so StyleCop will ignore BDD style tests
// </auto-generated>
//-------------------------------------------------------------------------------------------------

#pragma warning disable 169
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local

#endregion

namespace Endjin.Templify.Specifications
{
    #region Using Directives

    using System.Collections.Generic;
    using System.Linq;

    using Endjin.Templify.Domain.Domain.Packager.Specifications;
    using Endjin.Templify.Domain.Contracts.Infrastructure;

    using Machine.Specifications;
    using Machine.Specifications.AutoMocking.Rhino;

    #endregion

    public abstract class specification_for_file_exclusion_specification : Specification<FileExclusionSpecification>
    {
        protected static List<string> file_list;
        protected static IConfiguration config;

        private Establish context = () =>
            {
                subject.FileExclusions = new List<string> {".cache",".mst",".msm",".gitignore",".idx",".pack",".user",".resharper",".suo"};
                subject.DirectoryExclusions = new List<string> { "bin", "obj", "debug", "release", ".git" };

                file_list = new List<string>
                    {
                        @"C:\__NAME__\.git\hooks\applypatch-msg.sample",
                        @"C:\__NAME__\bin\hooks\applypatch-msg.sample",
                        @"C:\__NAME__\obj\hooks\applypatch-msg.sample",
                        @"C:\__NAME__\debug\hooks\applypatch-msg.sample",
                        @"C:\__NAME__\release\hooks\applypatch-msg.sample",
                        @"C:\__NAME__\hooks\applypatch-msg.cache",
                        @"C:\__NAME__\hooks\applypatch-msg.mst",
                        @"C:\__NAME__\hooks\.gitignore",
                        @"C:\__NAME__\hooks\applypatch-msg.idx",
                        @"C:\__NAME__\hooks\applypatch-msg.pack",
                        @"C:\__NAME__\hooks\applypatch-msg.user",
                        @"C:\__NAME__\hooks\applypatch-msg.resharper",
                        @"C:\__NAME__\hooks\applypatch-msg.suo",
                    };
            };
    } ;

    [Subject(typeof(FileExclusionSpecification))]
    public class when_the_file_exclusion_specification_is_given_a_list_of_items_to_exclude : specification_for_file_exclusion_specification
    {
        static IEnumerable<string> result;

        Because of = () => result = subject.SatisfyingElementsFrom(file_list.AsQueryable());

        It should_return_no_files = () => result.Count().ShouldEqual(0);
    }
}