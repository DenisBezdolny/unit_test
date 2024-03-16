using lesson_2___unit_testing;


namespace Lesson2_tests
{
    public class CatTests
    {
        [Fact]
        public void Miau_must_output_at_least_one_line_to_console()
        {
            //Arrange
            var output = new StringWriter();
            Console.SetOut(output);
            var cat = new Cat();

            //Act
            cat.Voice();

            //Assert
            var outputstring = output.ToString();
            var fistNewLineIndex = outputstring.IndexOf("\n");

            if (fistNewLineIndex < 0) {
                
                Assert.Fail("No lines found out of Voice() of the Cat");

             }


        }
    }
}