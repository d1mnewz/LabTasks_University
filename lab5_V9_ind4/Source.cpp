#include <stdio.h>
#include <stdlib.h>
#include <math.h>

//--------------------------
void Plo(double x, double y, double z)
{
	if (((x + y) >= z) &&
		((y + z) >= x) &&
		((z + x) >= y))
	{
		double pp = (x + y + z) / 2;

		double S = sqrt(pp*(pp - x)*(pp - y)*(pp - z));

		printf("S = %g\n", S);

	}
	else
		printf("Not possible.\n");

}
int main()
{
	double a = 7, b = 7, c = 7, d = 14;
	 
		    printf("Enter a b c d: \n");
	   scanf_s("%lf%lf%lf%lf",  &a,  &b,  &c,  &d);
	 
		 
		    printf("For a=%g,b=%g,c=%g \t",  a, b, c);
	   Plo(a, b, c);
	 
		    printf("For a=%g,b=%g,d=%g \t",  a, b, d);
	   Plo(a, b, d);
	 
		    printf("For a=%g,c=%g,d=%g \t",  a, c, d);
	   Plo(a, c, d);
	 
		    printf("For b=%g,c=%g,d=%g \t",  b, c, d);
	   Plo(b, c, d);
	 
		    return 0;
}
//--------------------------
