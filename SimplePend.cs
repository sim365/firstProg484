//============================================================================
// SimplePend.cs Defines a class for simulating a simple pendulum 
//============================================================================
using System;

namespace Sim
{
	public class SimplePend
	{
		private double len = 1.1; // pendulum length (m)
		private double g = 9.81; // gravitation field strength (m/s^2)

		//--------------------------------------------------------------------
		// constructor
		//--------------------------------------------------------------------
		public SimplePend()
		{
			Console.WriteLine("Inside constructor");
		}
		

		//--------------------------------------------------------------------
		// Getters and setters
		//--------------------------------------------------------------------
		public double L
		{
			get {return(len);}

			set
			{
				if(value > 0.0)
					len = value;
				
				//else
					//Console.WriteLine("Invalid number");
			}
		}

		public double G
		{
			get {return(g);}

			set
			{
				if(value > 0.0)
					g = value;
				
				//else
					//Console.WriteLine("Invalid number");
			}
		}



	}

}