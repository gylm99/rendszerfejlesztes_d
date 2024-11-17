<template>
  <!-- <IndexPage /> -->
  <!-- <SignIn /> -->
   <SignUp/>
</template>

<script>
// import IndexPage from './components/IndexPage.vue'
// import SignIn from './components/SignIn.vue'
import SignUp from './components/SignUp.vue'

export default {
  name: 'App',
  components: {
    // IndexPage,
    // SignIn,
    SignUp
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
img {
  width: 200px;
}
</style>
