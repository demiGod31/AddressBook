import Vue from 'vue'
import Router from 'vue-router'
import Home from './views/Home.vue'
import Add from './views/Add.vue'
import Show from './views/Show.vue'
import Delete from './views/Delete.vue'
import Update from './views/Update.vue'
Vue.use(Router)

export default new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [
    {
      path: '/',
      name: 'home',
      component: Home
    },
    {
      path: '/about',
      name: 'about',
      // route level code-splitting
      // this generates a separate chunk (about.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: () => import(/* webpackChunkName: "about" */ './views/About.vue')
    },
    {
      path: '/add',
      name: 'add',
      component: Add
    },
    {
      path: '/show',
      name: 'show',
      component: Show
    },
    {
      path: '/delete/:eID',
      name: 'delete',
      component: Delete
    },
    {
      path: '/update/:eID/:eNAME/:eNUMBER',
      name: 'update',
      component: Update
    }
  ]
})
