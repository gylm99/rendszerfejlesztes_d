import { createRouter, createWebHashHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import SignInView from '../views/SignInView.vue'
import SignUpView from '../views/SignUpView.vue'
import ItemView from '../views/ItemView.vue'
import ItemUploadView from '../views/ItemUploadView.vue'
import MyMessagesView from '../views/MyMessagesView.vue'



const routes = [
  {
    path: '/',
    name: 'home',
    component: 
    HomeView,
    SignInView,
    SignUpView,
    ItemView,
    ItemUploadView,
    MyMessagesView
  },
  {
    path: '/signin',
    name: 'signin',

    component: () => import(/* webpackChunkName: "about" */ '../views/SignInView.vue')
  },
  {
    path: '/signup',
    name: 'signup',

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
  },
  {
    path: '/mymessages',
    name: 'mymessages',
    component: () => import(/* webpackChunkName: "about" */ '../views/MyMessagesView.vue')
  }
]

const router = createRouter({
  history: createWebHashHistory(),
  routes
})

export default router
