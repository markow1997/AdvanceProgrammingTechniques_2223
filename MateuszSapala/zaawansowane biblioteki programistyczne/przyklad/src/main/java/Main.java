import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.databind.SerializationFeature;

import java.sql.SQLException;
import java.util.List;
import java.util.Scanner;

public class Main {
    private static final ObjectMapper mapper = new ObjectMapper().enable(SerializationFeature.INDENT_OUTPUT);

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        UserRepository userRepository;
        try {
            userRepository = new UserRepository();
        } catch (SQLException e) {
            System.out.println(e.getMessage());
            return;
        }
        UserService userService = new UserService(userRepository);


        System.out.println("Insert name: ");
        String name = scanner.next();
        System.out.println("Insert surname: ");
        String surname = scanner.next();
        userService.addUser(name, surname);

        List<User> users = userService.getUsers();
        try {
            System.out.println(mapper.writeValueAsString(users));
        } catch (JsonProcessingException e) {
            System.out.println(e.getMessage());
        }
    }
}
