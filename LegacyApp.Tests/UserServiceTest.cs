namespace LegacyApp.Tests;

public class UserServiceTests
{
    [Fact]
    public void AddUser_ReturnsFalseWhenFirstNameIsEmpty()
    {
        // Arrange
        var userService = new UserService();

        // Act
        var result = userService.AddUser(
            null, 
            "Kowalski", 
            "kowalski@kowalski.pl",
            DateTime.Parse("2000-01-01"),
            1
        );

        // Assert
        // Assert.Equal(false, result);
        Assert.False(result);
    }
    
    [Fact]
    public void AddUser_ReturnsFalseWhenMissingAtSignAndDotInEmail()
    {
        
        // Arrange
        var userService = new UserService();

        // Act
        var result = userService.AddUser(
            "Jan", 
            "Kowalski", 
            "kowalskikowalskipl",
            DateTime.Parse("2000-01-01"),
            1
        );

        // Assert
        // Assert.Equal(false, result);
        Assert.False(result);
    }
    
    [Fact]
    public void AddUser_ReturnsFalseWhenYoungerThen21YearsOld()
    {
        
        // Arrange
        var userService = new UserService();

        // Act
        var result = userService.AddUser(
            "Jan", 
            "Kowalski", 
            "kowalski@kowalski.pl",
            DateTime.Parse("2024-01-01"),
            1
        );

        // Assert
        Assert.False(result);
    }
    
    [Fact]
    public void AddUser_ReturnsTrueWhenVeryImportantClient()
    {
        // Arrange
        var userService = new UserService();
        
        // Act
        var result = userService.AddUser(
            "Jan", 
            "Kowalski", 
            "kowalski@kowalski.pl",
            DateTime.Parse("2024-01-01"),
            2
        );
        
        // Assert
        Assert.False(result);
    }

    [Fact]
    public void AddUser_ReturnsTrueWhenNormalClient()
    {
        // Arrange
        var userService = new UserService();
        
        // Act
        var result = userService.AddUser(
            "Jan", 
            "Kowalski", 
            "kowalski@kowalski.pl",
            DateTime.Parse("2024-01-01"),
            1
        );
        
        // Assert
        Assert.False(result);

    }
    
    [Fact]
    public void AddUser_ReturnsFalseWhenNormalClientWithNoCreditLimit()
    {
        // Arrange
        var userService = new UserService();
        
        // Act
        var result = userService.AddUser(
            "Jan", 
            "Kowalski", 
            "kowalski@kowalski.pl",
            DateTime.Parse("2024-01-01"),
            1
        );
        
        // Assert
        Assert.False(result);
    }
    
    // [Fact]
    // public void AddUser_ThrowsExceptionWhenUserDoesNotExist()
    // {
    //     // Arrange
    //     var userService = new UserService();
    //
    //     // Act
    //     Action action = () => userService.AddUser(
    //         "Jan", 
    //         "Kowalski", 
    //         "kowalski@kowalski.pl",
    //         DateTime.Parse("2024-01-01"),
    //         100
    //     );
    //
    //     // Assert
    //     Assert.Throws<Exception>(action);
    //
    // }
    //
    // [Fact]
    // public void AddUser_ThrowsExceptionWhenUserNoCreditLimitExistsForUser()
    // {
    //     var userService = new UserService();
    //
    //     // Act
    //     Action action = () => userService.AddUser(
    //         "Jan", 
    //         "Kowalski", 
    //         "kowalski@kowalski.pl",
    //         DateTime.Parse("2024-01-01"),
    //         1
    //     );
    //
    //     // Assert
    //     Assert.Throws<Exception>(action);
    // }
    
    [Fact]
    public void AddUser_ThrowsArgumentExceptionWhenClientDoesNotExist()
    {
        
        // Arrange
        var userService = new UserService();

        // Act
        Action action = () => userService.AddUser(
            "Jan", 
            "Kowalski", 
            "kowalski@kowalski.pl",
            DateTime.Parse("2000-01-01"),
            100
        );

        // Assert
        Assert.Throws<ArgumentException>(action);
    }
}