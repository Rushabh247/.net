async function loadUsers() {
  const res = await apiFetch("/User");
  const users = await res.json();

  const container = document.getElementById("users");
  container.innerHTML = `<h3>Manage Users</h3>
    <div>${users.map(u => `
      <div>
        ${u.username} (${u.role})
        <button onclick="deleteUser(${u.userId})">Delete</button>
      </div>`).join("")}</div>`;
}

async function deleteUser(id) {
  await apiFetch(`/User/${id}`, { method: "DELETE" });
  loadUsers();
}
