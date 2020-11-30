<template>
  <div>
    <b-form @submit="onSubmit" @reset="onReset" v-if="show">
     
        <b-form-group id="input-group-2" label="Your Name:" label-for="input-2">
        <b-form-input
          id="input-2"
          v-model="form.eName"
          required
          placeholder="Enter name"
        ></b-form-input>
      </b-form-group>

      <b-form-group id="input-group-3" label="Your Number:" label-for="input-3">
        <b-form-input
          id="input-3"
          v-model="form.eNumber"
          required
          placeholder="Enter Number"
        ></b-form-input>
      </b-form-group>

      <b-button type="submit" variant="primary">Submit</b-button>
      <b-button type="reset" variant="danger">Reset</b-button>
    </b-form>
    </div>
</template>

<script>
import axios from 'axios';
  export default {
    data() {
      return {
        form: {
          eId:0,
          eName: '',
          eNumber:''
        },
        
        show: true
      }
    },
    methods: {
      onSubmit(evt) {
        evt.preventDefault()
        alert("Data Succesfully Added!");
                axios.post('http://localhost:50069/api/AddressBook/Add',
                    this.form
                )
                .then((response) => {})
                .catch((evt) => {
                console.error(evt)
  })
      },
      onReset(evt) {
        evt.preventDefault()
        // Reset our form values
        this.form.eId=0
        this.form.eNumber = ''
        this.form.eName = ''
        // Trick to reset/clear native browser form validation state
        this.show = false
        this.$nextTick(() => {
          this.show = true
        })
      }
    }
  }
</script>