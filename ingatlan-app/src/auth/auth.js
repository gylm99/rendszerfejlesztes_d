import { reactive } from "vue";

export const authState = reactive({
  user: {username: "Teszt"}, // Null for visitors, or user object when signed in
});

export function signIn(user) {
  authState.user = user;
}

export function signOut() {
  authState.user = null;
}