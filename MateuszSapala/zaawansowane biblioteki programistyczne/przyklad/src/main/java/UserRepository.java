import java.sql.*;
import java.util.ArrayList;
import java.util.List;

public class UserRepository {
    private final Connection connection;

    public UserRepository() throws SQLException {
        connection = DriverManager.getConnection("jdbc:mysql://localhost:3306/demo_database", "user", "pass");
    }

    public void addUser(String name, String surname) throws SQLException {
        PreparedStatement stmt = connection.prepareStatement("INSERT INTO user (name, surname) VALUES(?,?)");
        stmt.setString(1, name);
        stmt.setString(2, surname);
        stmt.execute();
    }

    public List<User> getUsers() throws SQLException {
        Statement stmt = connection.createStatement();
        List<User> users = new ArrayList<>();
        ResultSet rs = stmt.executeQuery("SELECT id, name, surname from user");
        while (rs.next()) {
            users.add(User.builder()
                    .id(rs.getLong(1))
                    .name(rs.getString(2))
                    .surname(rs.getString(3))
                    .build());
        }
        return users;
    }
}

