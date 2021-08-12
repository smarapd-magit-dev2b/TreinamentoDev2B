export default function useLogout(props) {
  const { history } = props;

  localStorage.removeItem("pokerUser");
  localStorage.removeItem("active");

  history.push('/')
}

