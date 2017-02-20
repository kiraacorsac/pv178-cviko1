// usings

namespace ConsoleIO_01
{
    /// <summary>
    /// outlines main structure of general C# program, 
    /// all classes, enums, I-faces,... should be placed in separate files,
    /// projects are structured according to created directories, auto NS generation,
    /// Main method is the entry point (more details will be presented at lecture)
    /// </summary>
    class BaseStructure
    {
        // reference type
        class YourClass
        {
        }

        // value type
        struct YourStruct
        {
            // differences between structures and classes (only inherits from SystemValueType, cant have default CTOR ...):
            // https://msdn.microsoft.com/en-us/library/saxz13w4.aspx?f=255&MSPPError=-2147217396
        }

        interface IYourInterface
        {
        }

        enum YourEnum
        {
        }
    }

    //NS can be arbitrarily nested
    namespace YourNestedNamespace
    {
        // now YourStruct does NOT conflict with previously declared YourStruct since it lies in other NS
        struct YourStruct
        {
        }
    }
}
