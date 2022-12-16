import lombok.SneakyThrows;
import org.junit.jupiter.api.Disabled;
import org.junit.jupiter.api.Test;

import java.util.List;

import static org.junit.jupiter.api.Assertions.assertEquals;

class UserServiceTestWithoutMockito {
    @Test
    @Disabled("Incorrect test")
    @SneakyThrows
    void addUser() {
        // Arrange
        UserRepository UserRepository = new UserRepository();
        UserService userService = new UserService(UserRepository);

        // Act
        userService.addUser("Test", "Test");

        // Assert
        assertEquals(1, UserRepository.getUsers().size());
    }

    @Test
    @Disabled("Incorrect test")
    @SneakyThrows
    void getUser() {
        // Arrange
        UserRepository userRepository = new UserRepository();
        userRepository.addUser("Test1", "Test1");
        userRepository.addUser("Test2", "Test2");
        UserService userService = new UserService(userRepository);

        // Act
        List<User> actual = userService.getUsers();

        // Assert
        assertEquals(2, actual.size());
    }
}
