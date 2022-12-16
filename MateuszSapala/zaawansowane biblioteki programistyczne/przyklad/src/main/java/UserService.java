import lombok.RequiredArgsConstructor;
import org.apache.commons.lang3.StringUtils;

import java.sql.SQLException;
import java.util.List;

@RequiredArgsConstructor
public class UserService {
    private final UserRepository userRepository;

    public void addUser(String name, String surname) {
        try {
            if (StringUtils.isBlank(name) || !StringUtils.isAlpha(name)) {
                throw new IllegalArgumentException("Incorrect name provided");
            }
            if (StringUtils.isBlank(surname) || !StringUtils.isAlpha(surname)) {
                throw new IllegalArgumentException("Incorrect surname provided");
            }
            userRepository.addUser(name, surname);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }

    public List<User> getUsers() {
        try {
            return userRepository.getUsers();
        } catch (SQLException e) {
            System.out.println(e.getMessage());
        }
        return List.of();
    }
}
