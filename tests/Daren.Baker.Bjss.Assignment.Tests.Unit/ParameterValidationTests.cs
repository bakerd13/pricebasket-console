using Daren.Baker.Bjss.Assignment.Application;
using Daren.Baker.Bjss.Assignment.Application.Constants;
using FluentAssertions;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace Daren.Baker.Bjss.Assignment.Tests.Unit
{
    public class ParameterValidationTests
    {
        private IServiceProvider _serviceProvider;
        private IValidator<string[]> _validator;

        public ParameterValidationTests()
        {
            var services = new ServiceCollection();
            services.AddApplicationServices();
            _serviceProvider = services.BuildServiceProvider();

            _validator = _serviceProvider.GetService<IValidator<string[]>>();

        }

        [Fact]
        public void Parameter_Must_Not_Accept_Empty_Product_At_Begining()
        {
            // Arrange
            var args = new string[] { "", "Bread" };

            // Act
            ValidationResult results = _validator.Validate(args);

            // Assert
            results.IsValid.Should().BeFalse();

        }

        [Fact]
        public void Parameter_Must_Not_Accept_Empty_Product_At_End()
        {
            // Arrange
            var args = new string[] { "Bread", "" };

            // Act
            ValidationResult results = _validator.Validate(args);

            // Assert
            results.IsValid.Should().BeFalse();

        }

        [Fact]
        public void Parameter_Must_Not_Accept_Empty_Product_Anywhere()
        {
            // Arrange
            var args = new string[] { "Bread", "", "Soup" };

            // Act
            ValidationResult results = _validator.Validate(args);

            // Assert
            results.IsValid.Should().BeFalse();

        }

        [Fact]
        public void Parameter_Must_Not_Accept_Empty_Product_At_Begining_And_Contain_Message()
        {
            // Arrange
            var args = new string[] { "", "Bread" };

            // Act
            ValidationResult results = _validator.Validate(args);

            // Assert
            results.Errors.Should().Contain(x => x.ErrorMessage == MessageValues.EmptyArgument);
        }

        [Fact]
        public void Parameter_Must_Not_Accept_Empty_Product_At_End_And_Contain_Message()
        {
            // Arrange
            var args = new string[] { "Bread", "" };

            // Act
            ValidationResult results = _validator.Validate(args);

            // Assert
            results.Errors.Should().Contain(x => x.ErrorMessage == MessageValues.EmptyArgument);
        }

        [Fact]
        public void Parameter_Must_Not_Accept_Empty_Product_Anywhere_And_Contain_Message()
        {
            // Arrange
            var args = new string[] { "Bread", "", "Soup" };

            // Act
            ValidationResult results = _validator.Validate(args);

            // Assert
            results.Errors.Should().Contain(x => x.ErrorMessage == MessageValues.EmptyArgument);
        }

        [Fact]
        public void Parameters_Must_Accept_A_Single_Valid_Product()
        {
            // Arrange
            var args = new string[] { "Bread" };

            // Act
            ValidationResult results = _validator.Validate(args);

            // Assert
            results.IsValid.Should().BeTrue();

        }

        [Fact]
        public void Parameters_Must_Accept_A_Multiple_Valid_Products()
        {
            // Arrange
            var args = new string[] { "Bread", "Soup" };

            // Act
            ValidationResult results = _validator.Validate(args);

            // Assert
            results.IsValid.Should().BeTrue();

        }
    }
}
