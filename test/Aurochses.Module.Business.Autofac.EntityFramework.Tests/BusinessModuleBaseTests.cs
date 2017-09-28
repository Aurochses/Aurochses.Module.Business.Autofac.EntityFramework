using Xunit;

namespace Aurochses.Module.Business.Autofac.EntityFramework.Tests
{
    public class BusinessModuleBaseTests
    {
        private const string NameOrConnectionString = "Database";
        private const string SchemaName = "dbo";

        private readonly BusinessModuleBase _businessModuleBase;

        public BusinessModuleBaseTests()
        {
            _businessModuleBase = new BusinessModuleBase(NameOrConnectionString, SchemaName);
        }

        [Fact]
        public void Inherit_Module()
        {
            // Arrange & Act & Assert
            Assert.IsAssignableFrom<global::Autofac.Module>(_businessModuleBase);
        }

        [Fact]
        public void NameOrConnectionStringParameter_Value_Equals()
        {
            // Arrange & Act & Assert
            Assert.Equal("nameOrConnectionString", BusinessModuleBase.NameOrConnectionStringParameter);
        }

        [Fact]
        public void SchemaNameParameter_Value_Equals()
        {
            // Arrange & Act & Assert
            Assert.Equal("schemaName", BusinessModuleBase.SchemaNameParameter);
        }

        [Fact]
        public void NameOrConnectionString_Get_Success()
        {
            // Arrange & Act & Assert
            Assert.Equal(NameOrConnectionString, _businessModuleBase.NameOrConnectionString);
        }

        [Fact]
        public void SchemaName_Get_Success()
        {
            // Arrange & Act & Assert
            Assert.Equal(SchemaName, _businessModuleBase.SchemaName);
        }
    }
}