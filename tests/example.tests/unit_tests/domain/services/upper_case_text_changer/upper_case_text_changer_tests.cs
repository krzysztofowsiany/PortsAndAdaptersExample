namespace Example.Tests.unit_tests.domain.services.upper_case_text_changer {
    using Xunit;
    public class upper_case_text_changer_tests {

        [Theory]
        [InlineData("abc")]
        [InlineData("ABC")]
        [InlineData("1234*&*^")]
        public void return_upper_case__when__put_text(string message) {
            _fixture.set_text(message);

            var result = act();

            _fixture.assert_text_schould_be_upper_case(result);
        }

        private string act() {
            return _fixture.act();
        }

        private readonly upper_case_text_changer_tests_fixture _fixture;

        public upper_case_text_changer_tests() {
            _fixture = new upper_case_text_changer_tests_fixture();
        }
    }
}