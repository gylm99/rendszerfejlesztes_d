import { createRouter, createWebHashHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import SignInView from '../views/SignInView.vue'
import SignUpView from '../views/SignUpView.vue'
import ItemView from '../views/ItemView.vue'
import ItemUploadView from '../views/ItemUploadView.vue'



const routes = [
  {
    path: '/',
    name: 'home',
    component: 
    HomeView,
    SignInView,
    SignUpView,
    ItemView,
    ItemUploadView
  },
  {
    path: '/signin',
    name: 'signin',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/SignInView.vue')
  },
  {
    path: '/signup',
    name: 'signup',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/SignUpView.vue')
  },
  {
    path: '/item',
    name: 'item',
    component: () => import(/* webpackChunkName: "about" */ '../views/ItemView.vue')
  },
  {
    path: '/itemupload',
    name: 'itemupload',
    component: () => import(/* webpackChunkName: "about" */ '../views/ItemUploadView.vue')
  }
]

const router = createRouter({
  history: createWebHashHistory(),
  routes
})

export default router
