namespace Example.Tests.unit_tests.domain.services.upper_case_text_changer {
    using Example.Domain.Services;
    using System;
    using Shouldly;
    public class upper_case_text_changer_tests_fixture {
        private string _text;
        private readonly UpperCaseTextChanger _upperCaseTextChanger;

        internal void set_text(string text) =>
            _text = text;

        internal string act()
        {
            return _upperCaseTextChanger.Change(_text);
        }

        internal void assert_text_schould_be_upper_case(string result) {
            result.ShouldBe(_text.ToUpper());
        }
        public upper_case_text_changer_tests_fixture()
        {
            _upperCaseTextChanger = new UpperCaseTextChanger();
        }
    }
}