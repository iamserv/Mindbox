### Solution insights

For solution I used an abstract class as base class for shape, containing property 
to get area of shape, which has implementation in appropriate class.

I would do general logic for some shapes and basic calculations in the *shape* class,
but for this task i decided to leave area formulas for end user, as formulas are 
different from shape to shape

Since .NET 7, it would be better to use Generics types (as we have generic maths
interfaces like INumber), so, end user will be 
able to provide his own data type he wants, but this assumes a lot of extra work
with data validation, extra checks, which are out of the range of this task.


Checks for triangle, and null values are performed in constructor. It is not
a bad way, as I need object with appropriate data in it. There are more ways to achieve
validation, but for simplicity i decided to do it this way.