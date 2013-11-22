	==============================================================================
    The MIT License
	==============================================================================

    Copyright (c) 22/11/2013

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in
    all copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
    THE SOFTWARE.
 
    Thanks 
    Nino Khodabandeh
    Feel free to contribute :-)

	==============================================================================
	Documentation
	==============================================================================

	Note: The conversion only works for numbers up to: Trillion

	To convert:
		
	-------------------------e.g[ 1 --> one]---------------------------------

	int	----> string         
	
	string testString1 = NumberToString.StringFromNumber(10);

	-------------------------e.g[ 1 --> first]-------------------------------

	int(cardinal) ----> string(ordinal)  

	int intNum = 1;
	string ordinal = intNum.ToOrdinal();

	-------------------------e.g[ 1 --> first]-------------------------------

	long(cardinal) ----> string(ordinal)  

	long intNum = 100;
	string ordinal = intNum.ToOrdinal();

	-------------------------e.g[ one --> first]-------------------------------

	string(cardinal) ----> string(ordinal)  

	long intNum = 100;
	string ordinal = intNum.ToOrdinal();

	---------------------------------------------------------------------------