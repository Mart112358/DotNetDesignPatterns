namespace DotNetDesignPatterns.Composite
{
    public class CompositeTest
    {
        public static void Test()
        {
            //Initialize four ellipses
            var ellipse1 = new Ellipse("ellipse1");
            var ellipse2 = new Ellipse("ellipse2");
            var ellipse3 = new Ellipse("ellipse3");
            var ellipse4 = new Ellipse("ellipse4");

            //Initialize three composite graphics
            var graphic = new CompositeGraphic("graphic");
            var graphic1 = new CompositeGraphic("graphic1");
            var graphic2 = new CompositeGraphic("graphic2");

            //Composes the graphics
            graphic1.Add(ellipse1);
            graphic1.Add(ellipse2);
            graphic1.Add(ellipse3);

            graphic2.Add(ellipse4);

            graphic.Add(graphic1);
            graphic.Add(graphic2);

            //Prints the complete graphic (four times the string "Ellipse").
            graphic.Print();
        }
    }
}