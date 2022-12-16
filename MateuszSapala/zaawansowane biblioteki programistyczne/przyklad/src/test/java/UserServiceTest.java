import lombok.SneakyThrows;
import org.junit.jupiter.api.Test;
import org.mockito.Mockito;

import java.util.List;

import static org.junit.jupiter.api.Assertions.assertEquals;

class UserServiceTest {
    @Test
    @SneakyThrows
    void addUser() {
        // Arrange
        UserRepository userRepositoryMock = Mockito.mock(UserRepository.class);
        UserService userService = new UserService(userRepositoryMock);

        // Act
        userService.addUser("Test", "Test");

        // Assert
        Mockito.verify(userRepositoryMock).addUser("Test", "Test");
    }

    @Test
    @SneakyThrows
    void getUser() {
        // Arrange
        UserRepository userRepositoryMock = Mockito.mock(UserRepository.class);
        User test1 = new User(1L, "Test1", "Test1");
        User test2 = new User(2L, "Test2", "Test2");
        Mockito.when(userRepositoryMock.getUsers()).thenReturn(List.of(test1, test2));
        UserService userService = new UserService(userRepositoryMock);

        // Act
        List<User> actual = userService.getUsers();

        // Assert
        assertEquals(2, actual.size());
    }
}
