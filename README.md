# SolidPractice
This project is to practice SOLID concepts. reference from the book:Agile Principles, Patterns, and Practices in C#

There are some sample codes in five folder categories
1. SRP
   rectangle separate  GeometricRectangle and GraphicalRectangle, They all inherited Rectangle.
  GeometricRectangle is responsible for Aera return and GraphicalRectangle is responsible for Drawing the shape(just return width and height here).
2. OCP
  2.1 Use interface Shape to define Draw(), then let Square and Circle to inherit it. When call DrawAllShapes(), we just 
      use interface Shape to define the object list, then call Draw(). In the future, we just need to extend other Object inherited Shape. DrawAllShapes() 
	  can doesn’t need to modify.
  2.2 Test arraylist to sort shapes, but we don't want to modify shape and orther class, so use new Shapecomparer class inherit IComparer, just modify TestClass
  to used, Shape/Circle/Squire class don't need to modified.	  
