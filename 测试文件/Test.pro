
package test.pro;
message Test {
	optional bool test =1; 
	required double test1 = 2; 
	optional float test2 =3; 
	optional int32 test3 = 4; 
	optional uint32 test4 =5; 
	optional int64 test5 = 6; 
	optional uint64 test6 =7; 
	optional sint32 test7 = 8; 
	optional sint64 test8 =9; 
	optional fixed32 test9 = 10; 
	optional fixed64 test10 =11; 
	optional sfixed32 test11 = 12; 
	optional sfixed64 test12 =13; 
	optional string test13 = 14; 
	optional bytes test14 =15; 
	
	enum TestEnum 
    {
       testEnum1 = 1;
       testEnum2  = 2;
       testEnum3 = 3;
       testEnum4 = 4;
    }
}

