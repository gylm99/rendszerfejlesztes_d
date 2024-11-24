<script>
import { ref } from "vue";
import { authState, signOut } from "../auth/auth";

export default {
  setup() {
    const dropdownOpen = ref(false);

    function toggleDropdown() {
      dropdownOpen.value = !dropdownOpen.value;
    }

    return {
      auth: authState,
      dropdownOpen,
      toggleDropdown,
      signOut,
    };
  },
  name: "NavBar",
};
</script>

<template>
      <!-- Header -->
      <header class="bg-white shadow py-4 px-6 flex items-center justify-between">
        <!-- Search Bar -->
        <div class="flex items-center w-full max-w-md">
          <input
            type="text"
            placeholder="Search..."
            class="w-full px-4 py-2 border rounded-md border-green-300 focus:outline-none focus:border-green-800"
          />
          <button
            class="bg-green-600 text-white px-4 py-2 rounded-md hover:bg-green-900 focus:outline-none mx-5"
          >
            Filter
          </button>
        </div>
  
        <!-- Logo -->
        <router-link to="/">
          <h1 class="text-2xl font-semibold text-gray-800">Real Estate App</h1>
        </router-link>
  
        <!-- Navbar Buttons -->
        <div class="flex space-x-4">
          <template v-if="!auth.user">
            <!-- Sign In / Register Buttons -->
            <router-link to="/signin">
              <button
                @click="isSignInActive = true"
                class="px-4 py-2 bg-gray-300 text-gray-800 rounded-md hover:bg-gray-400 hover:text-white focus:outline-none"
              >
                Sign In
              </button>
            </router-link>
            <router-link to="/signup">
              <button
                class="px-4 py-2 bg-green-600 text-white rounded-md hover:bg-green-900 focus:outline-none"
              >
                Register
              </button>
            </router-link>
          </template>
          <template v-else>
            <!-- User Dropdown Menu -->
            <div class="relative">
              <button
                @click="toggleDropdown"
                class="flex items-center px-4 py-2 bg-green-600 text-white rounded-md hover:bg-green-900 focus:outline-none"
              >
                {{ auth.user.username }}
                <svg
                  xmlns="http://www.w3.org/2000/svg"
                  class="w-4 h-4 ml-2"
                  fill="none"
                  viewBox="0 0 24 24"
                  stroke="currentColor"
                >
                  <path
                    stroke-linecap="round"
                    stroke-linejoin="round"
                    stroke-width="2"
                    d="M19 9l-7 7-7-7"
                  />
                </svg>
              </button>
  
              <!-- Dropdown Menu -->
              <div
                v-if="dropdownOpen"
                class="absolute right-0 mt-2 w-48 bg-gray-100 rounded-md shadow-lg z-50"
              >
                <router-link
                  to="/messages"
                  class="block px-4 py-2 text-gray-700 hover:bg-gray-200"
                >
                  Messages
                </router-link>
                <router-link
                  to="/advertisements"
                  class="block px-4 py-2 text-gray-700 hover:bg-gray-200"
                >
                  Advertisements
                </router-link>
                <router-link
                  to="/profile"
                  class="block px-4 py-2 text-gray-700 hover:bg-gray-200"
                >
                  Profile
                </router-link>
                <button
                  @click="signOut"
                  class="w-full text-left px-4 py-2 text-gray-700 hover:bg-gray-200"
                >
                  Sign Out
                </button>
              </div>
            </div>
          </template>
        </div>
      </header>

  </template>